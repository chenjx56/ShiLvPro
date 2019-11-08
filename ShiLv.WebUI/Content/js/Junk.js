$('#selectList').change(function () {
    ajaxForJunks();
})
function ajaxForJunks() {
    $.ajax({
        url: '../Junk/GetJunksByPage',
        type: 'post',
        data: {
            typeID: $('#selectList').val().trim(),
            junkName: $('#JunkName').val().trim()
        },
        success: function (data) {
            junkName: $('#JunkName').val('');
            $('#junksContainer').html(data);
        }
    });
}
$('.search.bar6 button').click(function () {
    ajaxForJunks();
})
$('.search.bar6').keydown(function (e) {
    if(e.keyCode == 13){
        ajaxForJunks();
    }
});
var picString = null;
$("#picAjax").change(function (e) {
    var file = e.delegateTarget.files[0];
    //判断文件
    var path = $('#picAjax').val();
    if (path.length == 0) {
        $('.tips').html("请选择要上传的图片");
        $('.tips').css("color", "red");
        return;
    }
    var extStart = path.lastIndexOf('.'),
        ext = path.substring(extStart, path.length).toUpperCase();
    if (ext !== ".PNG" && ext !== ".JPG" && ext !== ".JPEG") {
        $('.tips').html('请选择png/jpg/jpeg格式');
        $('.tips').css("color", "red");
        return;
    }
    var reader = new FileReader();
    reader.readAsDataURL(file);
    reader.onload = function () {
        picString = reader.result;
        $("#selImg").attr({ "src": picString });
    }
});

$(function () {
    $('#btn-up').click(function () {
        if ($('.user-pic .name').html() == null) {
            alert('请登录账号后进行操作！');
            window.location.href = '../UserInfo/Index';
            return;
        }
        if ($('.add-box #selectList').val() == 0) {
            $('.tips').html('请选择分类！');
            $('.tips').css("color", "red");
            return;
        }
        if ($('#picAjax').val().length == 0) {
            $('.tips').html('请选择图片！');
            $('.tips').css("color", "red");
            return;
        }
        var formData = new FormData($('form')[0]);
        formData.append("junkName", $('#addName').val());
        formData.append("junkType", $('.add-box #selectList').val());
        formData.append("userName", $('.user-pic .name').attr("id"));
        $.ajax({
            url: '../Junk/SavePicture',
            type: 'post',
            data: formData,
            xhr: function () {
                return $.ajaxSettings.xhr();
            },
            success: function (data) {
                console.log(data);
            },
            cache: false,
            contentType: false,
            processData: false
        });
    });

    $('.add-box .icon-cha').click(function () {
        $('.add-bg').fadeOut(300);
    })
    $('.icon-jia').click(function () {
        $('.add-bg').fadeIn(300);
    })
});


