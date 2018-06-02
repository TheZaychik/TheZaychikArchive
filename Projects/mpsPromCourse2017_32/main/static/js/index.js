	var div = document.getElementById("jb");
	var jpg = true;
	div.onclick = function about(){
	 if(jpg) {
      $("#jb2").fadeIn(500);
     } else {
      $("#jb2").fadeOut(500);
     }
     jpg = !jpg;
	}