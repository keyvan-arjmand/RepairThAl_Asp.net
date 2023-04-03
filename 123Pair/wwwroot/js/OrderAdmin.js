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

    var RepairDate = '0000/00/00';

    $('#Repair_date_textbox').dxTextBox({
        value: RepairDate,
    });

    $("#Repair_date_textbox").persianDatepicker({
        selectedDate: RepairDate,
        formatDate: "YYYY/0M/0D"
    });



    $(".OrderDetail").click(function () {
        var currentrow = $(this).closest("form");
        document.getElementById('myModal').style.display = 'block';
        $("#OrderType").val(currentrow.find('input[name="nOrderType"]').val());
        $("#BuildServiceType").val(currentrow.find('input[name="nBuildServiceType"]').val());
        $("#Device_Type").val(currentrow.find('input[name="nDevice_Type"]').val());
        $("#Brand").val(currentrow.find('input[name="nBrand"]').val());
        $("#Order_Desc").val(currentrow.find('input[name="nOrder_Desc"]').val());
        $("#State").val(currentrow.find('input[name="nState"]').val());
        $("#Address").val(currentrow.find('input[name="nAddress"]').val());
        $("#Order_PhoneNumber").val(currentrow.find('input[name="nOrder_PhoneNumber"]').val());
        $("#Order_State").val(currentrow.find('input[name="nOrder_State"]').val());
        $('#Repair_date_textbox').val(currentrow.find('input[name="nOrder_Repair_Date"]').val())
        $('#Order_Request_Date').val(formatDate(currentrow.find('input[name="nOrder_Request_Date"]').val()));
        $("#PhoneNumber").val(currentrow.find('input[name="nPhoneNumber"]').val());
        $("#Order_Code").val(currentrow.find('input[name="nOrder_Code"]').val());
        $("#FirstName").val(currentrow.find('input[name="nFirstName"]').val());
        $("#LastName").val(currentrow.find('input[name="nLastName"]').val());
        $("#Email").val(currentrow.find('input[name="nEmail"]').val());
        $("#User_ID").val(currentrow.find('input[name="nUser_ID"]').val());
        $("#Order__ID").val(currentrow.find('input[name="nOrder__ID"]').val());
        $("#Order__IDRemove").val(currentrow.find('input[name="nOrder__ID"]').val());
    });

    $("#Edit").click(function () {
        loadPanel.show();
        FormData = {

            Order_Repair_Date: unformatDate($("#Repair_date_textbox").val()),
            OrderType: $("#OrderType").val(),
            Device_Type: $("#Device_Type").val(),
            Brand: $("#Brand").val(),
            BuildServiceType: $("#BuildServiceType").val(),
            Order_Desc: $("#Order_Desc").val(),
            Address: $("#Address").val(),
            Order_Request_Date: unformatDate($("#Order_Request_Date").val()),
            Order_Code: $("#Order_Code").val(),
            User_ID: $("#User_ID").val(),
            State: $("#State").val(),
            Order_State: $("#Order_State").val(),
            Order__ID: $("#Order__ID").val(),
        }
        $.ajax({
            type: "POST",
            data: FormData,
            url: "/Order/Update",
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
        loadPanel.show()
        FormData = {
            Order__ID: $("#Order__ID").val(),
        }
        $.ajax({
            type: "POST",
            data: FormData,
            url: "/Order/Delete",
            success: function (data) {
                loadPanel.hide()
                DevExpress.ui.dialog.alert("درخواست با موفقیت حذف شد", "پیام");
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

});