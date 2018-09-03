window.onload = function () {

    var searchInput = document.getElementsByClassName('dataTables_filter')[0].getElementsByTagName('input')[0];
    //alert("onload");
    searchInput.onkeyup = function () {
        //alert("onchange");
        if (searchInput.value.trim() == "") {
            //alert("red");
            searchInput.style.borderColor = "inherit";
        }
        else {
            //alert("yellow");
            searchInput.style.borderColor = "blueviolet";
        }
    };

};



var regex = /^\d{0,9}(\.\d{0,2})?$/;
$(".currency").on("keyup", function () {
    //alert("currency");
    var valid = regex.test(this.value),
        val = this.value;
    var pos = this.selectionStart - 1;

    if (!valid) {
        if (typeof this.lastValid != "undefined") {
            this.value = this.lastValid
            this.setSelectionRange(pos, pos);
        } else {
            this.value = "";
        }
    } else {
        this.lastValid = val;
    }
});

$(".currency").bind("paste", function (e) {
    // access the clipboard using the api
    var pastedData = e.originalEvent.clipboardData.getData('text');

    if (!regex.test(pastedData)) {
        e.preventDefault();
    }
});