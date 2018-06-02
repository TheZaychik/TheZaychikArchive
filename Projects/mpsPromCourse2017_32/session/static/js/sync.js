"use strict";

const OPEN = 1; // WebSocket const
let ignore = false;


let generateUnique = (function () {
	let a = "";
	
	return function (length = 6) {
		if (a == "") {
			for (let i = 0; i < length; i++) {
				a += String.fromCharCode(Math.random() * 1000 % 74 + 48);
			}
		}

		return a;
	}
})();


(function syncListenInit() {
	let syncListenSocket = new WebSocket("ws://" + window.location.host + "/sync/listen/");

	syncListenSocket.onmessage = diff => {
		let data = JSON.parse(diff.data);

		let text = upperForm.getValue()
		data.pull.forEach(item => {
			text = applyChange(text, item);
		});
		ignore = true;
		upperForm.setValue(text, upperForm.getCursorPosition());
		ignore = false;

		syncListenSocket.send(JSON.stringify({token: token, origin: generateUnique()}));
	};

	syncListenSocket.onerror = () => console.log("sync/listen seems to be unresponding");
	syncListenSocket.onopen = () => syncListenSocket.send(JSON.stringify({token: token, origin: generateUnique()}));
})();


function c_sendData () {
	let syncTellSocket = new WebSocket("ws://" + window.location.host + "/sync/tell/");

	syncTellSocket.onerror = () => console.log("sync/tell seems to be unresponding");
	syncTellSocket.onmessage = mess => {
		let data = JSON.parse(mess.data);

		if (data.inapt == true) {
			ignore = true;
			upperForm.setValue(data.refText, upperForm.getCursorPosition());
			ignore = false;
		}
	}

	const HASH_TIME = 2000;

	let _pack = {
		type: 'pack',
		length: 0,
		pull: [],
		origin: generateUnique(),
		token: token,
		hashCheck: false,
		textHash: "",
	};
	let pack = $.extend(true, {}, _pack);
	let time = setInterval(() => hash = true, HASH_TIME);
	let hash = false;

	return function i_sendData (so, forceHash) {
		if (ignore)
			return;

		so = $.extend(true, {}, so);

		if (so.type == "hashCheck") {
			pack.hashCheck = true;
			forceHash = true;
		} else {
			pack.pull.push(so);
		}
		
		pack.length = pack.pull.length;

		if (forceHash || hash) {
			hash = false;
			pack.textHash = md5(upperForm.getValue());
		}

		if (syncTellSocket.readyState == OPEN) {
			syncTellSocket.send(JSON.stringify(pack));
			pack = $.extend(true, {}, _pack);
		} else {
			syncTellSocket.onopen = () => {
				syncTellSocket.send(JSON.stringify(pack));
				syncTellSocket.onopen = null;
				pack = $.extend(true, {}, _pack);
			};
		}
	};
}


function applyChange (text = "", so = {}) {
	let neu = text.split("\n");
	let left = "", rest = "";

	switch(so.action) {
		case "insert":
			left = neu[so.start.row].slice(0, so.start.column);
			rest = neu[so.start.row].slice(so.start.column);
			neu[so.start.row] = left + so.lines.join("\n") + rest;
			break;
			
		case "remove":
			left = neu[so.start.row].slice(0, so.start.column);
			rest = neu[so.end.row].slice(so.end.column);
			neu.splice(so.start.row, so.lines.length, [left + rest]);
			break;
	}

	return neu.join("\n");
}