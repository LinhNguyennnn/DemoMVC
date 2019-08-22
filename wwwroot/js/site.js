// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function ConfirmPW() {
    let pw = document.getElementById("pass").value;
    let pw2 = document.getElementById("pass2").value;
    if (pw !== pw2) {
        document.getElementById("errPass").style.display = "block"
        document.getElementById("but").disabled = true;
    }
    else {
        document.getElementById("errPass").style.display = "none";
        document.getElementById("but").disabled = false;
    }
}

// function CheckReceiver() {
//     let Recei = document.getElementById("recei").value;
//     let user = dbContext.Users.FirstOrDefault(x => x.Username == receiver);
//     if (Recei === user.) {
        
//     }
// }