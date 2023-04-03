var loadPanel = $('.loadpanel').dxLoadPanel({
    shadingColor: 'rgba(0,0,0,0.4)',
    visible: false,
    showIndicator: true,
    showPane: true,
    shading: true,
    hideOnOutsideClick: false,
    message: "لطفا منتظر باشید"
}).dxLoadPanel('instance');


$(document).ready(function () {

    $("#SaveBtn").click(function () {

        loadPanel.show();

        FormData = {
            FirstName: $("#Firstname").val(),
            LastName: $("#LastName").val(),
            PhoneNumber: $("#Number").val(),
            Email: $("#Email").val(),
            Password: $("#Password").val()
        }
        $.ajax({
            type: "POST",
            data: FormData,
            url: "/Account/SignUp",
            success: function (data) {
                loadPanel.hide();
                window.location.href = "/Home/Index";
            },
            error: function (xhr) {
                loadPanel.hide();
                if (xhr.responseText) {
                    var error = xhr.responseText.replace("System.Exception:", "");
                    error = error.split("\r\n");
                    DevExpress.ui.dialog.alert(error[0], "خطا");
                }

            }
        });
    });
});

