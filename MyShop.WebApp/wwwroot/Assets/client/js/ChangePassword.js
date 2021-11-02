$(document).ready(function () {
    $('#edit').click(function () {

        var oldpass = $('#oldpass').val();
        var newpass = $('#newpass').val();
        var confirm = $('#confirm').val();
        // alert(oldpass + newpass + confirm);

        $.ajax({
            url: '/Home/SaveChangePassword',
            method: "POST",
            data: { oldpass: oldpass, newpass: newpass, confirm: confirm },
            dataType: 'Json',
            success: function (result) {
                alert(result);

            },
            error: function () {
                alert("Thất bại!");

            }
        });
    })
})