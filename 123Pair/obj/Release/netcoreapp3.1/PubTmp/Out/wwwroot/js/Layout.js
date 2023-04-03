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

    $("#LoginBtn").click(function () {

        loadPanel.show();

        FormData = {
            Email: $("#EmailLoginLayout").val(),
            Password: $("#PasswordLoginLayout").val()
        }
        $.ajax({
            type: "POST",
            data: FormData,
            url: "/Account/login",
            success: function (data) {
                loadPanel.hide();
                window.location.href = "/Account/UserProfile";
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
    $("#LoginBtnMobile").click(function () {

        loadPanel.show();

        FormData = {
            Email: $("#EmailLoginLayoutMobile").val(),
            Password: $("#PasswordLoginLayoutMobile").val()
        }
        $.ajax({
            type: "POST",
            data: FormData,
            url: "/Account/login",
            success: function (data) {
                loadPanel.hide();
                window.location.href = "/Account/UserProfile";
            }, 
            error: function(xhr) {
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

