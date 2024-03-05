function hide(id) {
    item = document.getElementById(id);
    if (item.classList.contains("hide")) {
        item.classList.remove("hide");
        item.classList.add("show");
        return;
    }
    item.classList.remove("show");
    item.classList.add("hide");
}

function hideDropdown(id) {
    dropdownId = id + "dropdown";
    childnode = document.getElementById(dropdownId).childNodes[1]
    hide(dropdownId);
    hide(childnode.id);
}