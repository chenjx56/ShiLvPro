$('.nav-wrapper .nav').animate({
    width:'90%',
    fontSize:'20px'
},600) 
$('.nav-wrapper .nav-logo').fadeIn(800,'linear',function(){
    $(this).animate({
        width: '100px',
        height: '100px',
        left: '50%',
        top: '50%', 
        marginLeft: '-50px',
        marginTop: '-50px'
    },function(){
        if ($(document).width()>=1180){
            $(".nav-wrapper .user-pic").animate({
            top:'58%',
            marginTop:"-32.5px"
            },800)
        }     
    })
});  
$(document).on("resize",function(){
    if($(this).width()<=1179)
    {
        $(".nav-wrapper .user-pic").stop().animate({
            top:'-100px',
            marginTop:"-32.5px"
        },500)
    }
    if($(this).width()>=1180)
    {
        if ($(document).width()>1180){
            $(".nav-wrapper .user-pic").stop().animate({
            top:'58%',
            marginTop:"-32.5px"
            },800)
        }   
    }
})   
//回到顶部
$('.to-up-page').hide();
$(window).scroll(function () {
    $('.to-up-page').css({ bottom: '100px' });
    if ($(window).scrollTop() > 50) {
        $('.to-up-page').fadeIn(500);
    } else {
        $('.to-up-page').fadeOut(200);
    }
})
$('.to-up-page').click(function () {
    $('body,html').animate({ scrollTop: 0 }, 500);
    $('.to-up-page').animate({ bottom: '100%', opacity: 0 }, 800, function () {
        $('.to-up-page').css({ opacity: 1 });
    });
})
//退出登录
$(document).on('click', '.logout', function () {
    $.ajax({
        url: '/UserInfo/Logout',
        type: 'post',
        success: function (data) {
            if (data == "success") {
                $('.user-pic').html('<a href="../UserInfo/Index"><img src="../Content/images/headImage1.png" alt=""></a>');
            }
        }
    });
});