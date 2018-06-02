"use strict";

let upperForm  = $('.upperForm');
let bottomForm = $('.bottomForm');

$('body').on("click", ".runButton", {text: "initial", type: "initial"}, function responseParse (event) {
	$(this).attr("value", "Running...");
	$(this).prop("disabled", true);

	if (event.data.text == "initial")
		event.data.text = upperForm.val()

	$.post({
		url: configuration.py_network.comp_url, 
		data: JSON.stringify({text: event.data.text, type: event.data.type}), 
		success: response => {
			console.log(response);
			bottomForm.val((i, curr) => curr + response.output);

			let textWith = "";
			switch (response.state) {
				case 0: // in progress (timed out)
					responseParse({data: {text: "", type: "continue"}});
					break;
				case 1: // input required
					bottomForm.on("keypress", event => {
						if (event.which != 13) {
							textWith += String.fromCharCode(event.charCode);
							return true;
						}

						responseParse({data: {text: textWith, type: "continue"}});
						bottomForm.off();
					});
					break;
				case 2: // done
				case 3: // error
					$(this).attr("value", "Run");
					$(this).prop("disabled", false);
			}
		},
		crossDomain: true,
	}).fail(event => console.log(event.statusText));
});