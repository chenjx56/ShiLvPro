$('.btn-login').on('click', function () {
    if ($('#UserName').val().length == 0) {
        $('.tips').html('请输入用户名！');
    } else if ($('#UserPwd').val().length == 0) {
        $('.tips').html('请输入密码！');
    } else {
        $.ajax({
            url: "/UserInfo/Login",
            type: "post",
            data: {
                UserName: $('#UserName').val(),
                UserPwd: $('#UserPwd').val()
            },
            success: function (data) {
                if (data == "登录成功") {
                    window.location.href = '../Home/Index';
                } else {
                    $('.tips').html('用户名或密码错误！');
                    $('#UserName').val('');
                    $('#UserPwd').val('');
                    $('#UserName').focus();
                }
            }
        });
    }
})