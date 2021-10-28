$(document).ready(function () {
    $('#contact_get').click(function () {

        var contact_name = $('#contact_name').val();
        var contact_email = $('#contact_email').val();
        var contact_title = $('#contact_title').val();
        var contact_content = $('#contact_content').val();


        $.ajax({
            url: '/Home/SendEmail',
            method: "POST",
            data: { contact_name: contact_name, contact_email: contact_email, contact_title: contact_title, contact_content: contact_content },
            dataType: 'Json',
            success: function (result) {
                alert("Đã gửi thành công!");

            },
            error: function () {
                alert("Thất bại!");

            }
        });
    })
})