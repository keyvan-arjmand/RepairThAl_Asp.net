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
    var OrderType = 0;

    $("#HomeRePair").css("color", "#212529");
    $("#HomeRePair").css('background-color', "#FFC600");
    $("#HomeRePair").css('border-color', "#FFC600");

    $(".Build").css('display', "none");

    $("#HomeRePair").click(function () {

        $(this).css("color", "#212529");
        $(this).css('background-color', "#FFC600");
        $(this).css('border-color', "#FFC600");
        OrderType = 0;
        $("#BuildRePair").css('color', "#FFC600");
        $("#BuildRePair").css('background-color', "transparent");
        $("#BuildRePair").css('border-color', "#FFC600");

        $("#FormType").val("0");

        $(".Build").hide();
        $(".Home").show();
    });

    $("#BuildRePair").click(function () {

        $(this).css("color", "#212529");
        $(this).css('background-color', "#FFC600");
        $(this).css('border-color', "#FFC600");
        OrderType = 1;
        $("#HomeRePair").css('color', "#FFC600");
        $("#HomeRePair").css('background-color', "transparent");
        $("#HomeRePair").css('border-color', "#FFC600");

        $("#FormType").val("1");

        $(".Home").hide();
        $(".Build").show();
    });
    function FeedHref() {
        window.location.href = "/Account/UserProfile", true;
    }
    function AjaxBuild() {
        loadPanel.show();
        FormData = {
            BuildServiceType: $("#BuildServiceType").val(),
            Order_Desc: $("#Order_Desc_Build").val(),
            State: $("#State_Build").val(),
            Address: $("#Address_Build").val(),
            Order_PhoneNumber: $("#Order_PhoneNumber_Build").val(),
            OrderType: OrderType,
        }
        var ajax = $.ajax({
            type: "POST",
            data: FormData,
            url: "/Order/Insert",
            dataType: "html",
            success: function (data) {
                loadPanel.hide();
                DevExpress.ui.dialog.alert("سفارش با موفقیت ثبت شد", "پیام");
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

    }
    function AjaxHome() {
        loadPanel.show()
        FormData = {
            Brand: $("#Brand").val(),
            Device_Type: $("#Device").val(),
            Order_Desc: $("#OrderDesc").val(),
            State: $("#State").val(),
            Address: $("#OrderAddress").val(),
            Order_PhoneNumber: $("#OrderNumber").val(),
            OrderType: OrderType,
        }
        $.ajax({
            type: "POST",
            data: FormData,
            url: "/Order/Insert",
            success: function (data) {
                loadPanel.hide()
                DevExpress.ui.dialog.alert("سفارش با موفقیت ثبت شد", "پیام");
                window.location.href = "/Account/UserProfile";
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
    }

    $("#HomeSubmit").click(function () {
        AjaxHome();
        FeedHref();

    });

    $("#BuildSubmit").click(function () {
        AjaxBuild();
        FeedHref();
    });
});
