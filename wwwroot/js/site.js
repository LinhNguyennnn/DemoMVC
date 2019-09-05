// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

// Check valid re-password

function ConfirmPW() {
    let pw = document.getElementById("pass").value;
    let pw2 = document.getElementById("pass2").value;
    if (pw !== pw2) {
        document.getElementById("errPass").style.display = "block";
        document.getElementById("but").disabled = true;
    }
    else {
        document.getElementById("errPass").style.display = "none";
        document.getElementById("but").disabled = false;
    }
}

// Split string name

var listName = document.getElementsByClassName('js-formatInputName')[0];
var wrapCompose = document.getElementsByClassName('wrap-compose')[0];
var NameReceiver = document.getElementsByClassName('receiver');
listName.addEventListener('keyup', (e, v) => {
    var userNameHtml = document.createElement("span");
    var textnode = document.createTextNode(listName.value);
    userNameHtml.appendChild(textnode);
    userNameHtml.classList.add('receiver');

    if (e.keyCode == 13 || e.keyCode == 9 || e.w) {

        wrapCompose.insertBefore(userNameHtml, wrapCompose.childNodes[NameReceiver.length + 1]);
        listName.value = '';
        console.log(NameReceiver.length + 1);
        e.preventDefault();
    } else if (e.keyCode == 8) {
        wrapCompose.removeChild(wrapCompose.childNodes[NameReceiver.length]);
    }
})
listName.addEventListener('keydown', (e) => {
    if (e.keyCode == 9) {
        e.preventDefault();
    }
})
var btnSendEmail = document.getElementById('send');
btnSendEmail.addEventListener('click', () => {
    var listNameUser = '';
    for (let i = 0; i < NameReceiver.length; i++) {

        listNameUser += NameReceiver[i].innerText + ',';
    }
    document.getElementById('receiver').value = listNameUser;
})

// Display detail

function detail(re_name, mail_title, mail_content) {
    document.getElementById("title-detail").innerHTML = mail_title;
    document.getElementById("receiver-detail").innerHTML = re_name;
    document.getElementById("content-detail").innerHTML = mail_content;
    document.getElementById("hihi").style.display = "none";
    document.getElementById("haha").style.display = "none";
    document.getElementById("maildetail").style.display = "block";
}

function send() {
    document.getElementById("title-detail").innerHTML = null;
    document.getElementById("receiver-detail").innerHTML = null;
    document.getElementById("content-detail").innerHTML = null;
    document.getElementById("hihi").style.display = "block";
    document.getElementById("maildetail").style.display = "none";
}

function receiver() {
    document.getElementById("title-detail").innerHTML = null;
    document.getElementById("receiver-detail").innerHTML = null;
    document.getElementById("content-detail").innerHTML = null;
    document.getElementById("haha").style.display = "block";
    document.getElementById("maildetail").style.display = "none";
}