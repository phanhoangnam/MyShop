
$(document).ready(function () {
    $('#binh_luan').click(function () {

        var noidung = $('#noidung').val();
        var maSP = $('#maSP').val();

        $.ajax({
            url: '/Product/AddBinhLuan',
            method: "POST",
            data: { noidung: noidung, maSP: maSP },
            dataType: 'Json',
            success: function (result) {
                if (result != " ") {
                    $(".reviews").append('<div class="review">' +
                        '<div class= "review-title" > <span class="summary">' + result[1] + '</span></div>' +
                        '<div class="text">' + result[0].NoiDungBL + '</div>' +
                        '</div>');
                }
                else {
                    alert("Vui lòng đăng nhập!");
                }
            },
            error: function (errormessage) {
                alert(errormessage.responseText);
            }
        });

       
    })
})



