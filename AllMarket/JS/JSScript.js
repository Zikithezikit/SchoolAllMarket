function password(txtBox) { // מראה את הסיסמה
    var id = document.getElementById(txtBox); // מזהה את הכפתור באמצעות id
    if (id.type === "password") { // אם הסוג היה סיסמה (*****) הוא שונה לטקסט
        id.type = "text";
    } else { //אם הסוג היה טקסט הוא שונה לסיסמה (*****) י.
        id.type = "password";
    }
}
function showimagepreview1(event) {
    //יוצר כתובת זמנית כדי להראות את התמונה לפני שמירה באתר
    var img = document.getElementById("image_upload_preview");
    img.src = URL.createObjectURL(event.target.files[0]);
}
function ClickPrewiew() {
    document.getElementById("btn_Submit").click();
}
function ClickButton(clicked_id) {
    str = clicked_id.substring(0, clicked_id.leangth - 1);
    var Button = document.getElementById("btn_AddToFavorite");
    Button.click(str);
}
function AddToFavorite() {
    //בודק שהמשתמש אינו אורח ולכן יכול להוסיף מוצר למועדפים
    var userName = document.getElementById("lbl_UserName").innerText.toString();
    if (userName == "guest") {
        document.getElementById("btn_login_goto").click();
    }
    else {

        // משיג את ה ID של הכפתור שהפעיל את הפעולה
        var button = event.target;
        var buttonId = button.id;




        // צור קישור עם הערך שצריך להעביר

        var userValue = buttonId;
        var url = "TransferValue.aspx/HighSc?userValue=" + encodeURIComponent(userValue).toString() + "&userName=" + encodeURIComponent(userName).toString();
        // שלח את הקישור

        window.open(url);
    }

    
}

function DeleteFavorite() {
    var userName = document.getElementById("lbl_UserName").innerText.toString();

    // משיג את ה ID של הכפתור שהפעיל את הפעולה
    var button = event.target;
    var buttonId = button.id;




    // צור קישור עם הערך שצריך להעביר

    var userValue = buttonId;
    var url = "DeleteFromFavorite.aspx/HighSc?userValue=" + encodeURIComponent(userValue).toString() + "&userName=" + encodeURIComponent(userName).toString();
    // שלח את הקישור

    window.open(url);

   
};
function DeleteProduct() {
    // משיג את ה ID של הכפתור שהפעיל את הפעולה
    var button = event.target;
    var buttonId = button.id;

    // צור קישור עם הערך שצריך להעביר
    var userValue = buttonId;
    var url = "DeleteProduct.aspx/HighSc?userValue="+encodeURIComponent(userValue).toString()+""
    window.open(url);
};