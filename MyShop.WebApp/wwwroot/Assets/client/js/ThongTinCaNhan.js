
$(document).ready(function () {
    $('#save').click(function () {

        var username = $('#username').val();
        var name = $('#name').val();
        var email = $('#email').val();
        var phone = $('#phone').val();
        var address = $('#address').val();

        $.ajax({
            url: '/Home/UpdateUser',
            method: "POST",
            data: { username: username, name: name, email: email, phone: phone, address: address },
            dataType: 'Json',
            success: function (result) {
                alert("Cập nhật thành công!");

            },
            error: function () {
                alert("Cập nhật thất bại!");

            }
        });
    })
})
