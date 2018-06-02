navIsOpen = false;
function openNav() {
    document.getElementById("mySidenav").style.width = "20%";
    document.getElementById("main").style.marginRight = "20%";
}

function closeNav() {
    document.getElementById("mySidenav").style.width = "0";
    document.getElementById("main").style.marginRight = "0";
}

function toggleNav() {
    if (navIsOpen){
        closeNav();
    }
    else {
        openNav();
    }
    navIsOpen = !navIsOpen;
}