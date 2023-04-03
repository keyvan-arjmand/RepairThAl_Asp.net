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

    $("#Edit").click(function () {
        loadPanel.show()
        FormData = {

            User__ID: $("#User_ID").val(),
            FirstName: $("#FirstName").val(),
            LastName: $("#LastName").val(),
            PhoneNumber: $("#PhoneNumber").val(),
            Instagram: $("#Instagram").val(),
            Email: $("#Email").val(),
            Password: $("#Password").val(),
            JoinDate: $("#JoinDate").val(),
            IsAdmin: false,
        }
        if ($("#IsAdmin").val() == 0) {
            FormData.IsAdmin = true;
        } else {
            FormData.IsAdmin = false;

        }
        $.ajax({
            type: "POST",
            data: FormData,
            url: "/User/EditUser",
            success: function (data) {
                loadPanel.hide()
                DevExpress.ui.dialog.alert("تغیرات با موفقیت اعمال شد", "پیام");
                location.reload();
            },
            error: function (xhr) {
                loadPanel.hide()
                if (xhr.responseText) {
                    var error = xhr.responseText.replace("System.Exception:", "");
                    error = error.split("\r\n");
                    DevExpress.ui.dialog.alert(error[0], "خطا");
                }

            }
        });

    });
    $("#Delete").click(function () {
        FormData = {

            User__ID: $("#User_ID").val(),
            FirstName: $("#FirstName").val(),
            LastName: $("#LastName").val(),
            PhoneNumber: $("#PhoneNumber").val(),
            Instagram: $("#Instagram").val(),
            Email: $("#Email").val(),
            Password: $("#Password").val(),
            JoinDate: $("#JoinDate").val(),
            IsAdmin: false,
        }
        if ($("#IsAdmin").val() == 0) {
            FormData.IsAdmin = true;
        } else {
            FormData.IsAdmin = false;

        }
        $.ajax({
            type: "POST",
            data: FormData,
            url: "/User/DeleteUser",
            success: function (data) {
                DevExpress.ui.dialog.alert("درخواست با موفقیت حذف شد", "پیام");
                location.reload();
            },
            error: function (xhr) {
                if (xhr.responseText) {
                    var error = xhr.responseText.replace("System.Exception:", "");
                    error = error.split("\r\n");
                    DevExpress.ui.dialog.alert(error[0], "خطا");
                }

            }
        });

    });

})