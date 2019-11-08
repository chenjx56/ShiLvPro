//打开导航栏提示
$('.top-nav .hover-box').mouseenter(function(){
    if(!$('.top-nav').hasClass('active')){ 
        function shinny(){
            $('.top-nav .click-hand').stop().animate({opacity:'1'},200).delay(400).animate({opacity:'0'},200);
        }
        $('.top-nav .click-hand').stop().animate({opacity:'1'},200).delay(400).animate({opacity:'0'},200);
        timer = setInterval(shinny,1200)   
    }
})
$('.top-nav .hover-box').mouseleave(function(){
    if(!$('.top-nav').hasClass('active')){
        clearInterval(timer);
        $('.top-nav .click-hand').stop(true,false);  
        $('.click-hand').css("opacity","0");
    }
})

//打开/关闭导航栏
$('.top-nav').click(function(){
    $(this).toggleClass('active');
    $('.top-logo').toggleClass('active');
    clearInterval(timer);
    $('.top-nav .click-hand').stop(true,false);
    $('.click-hand').css("opacity","0");
})

//调整轮播图大小
$('.banner').height($('.banner img').height());
$(window).resize(function(){
    $('.banner').height($('.banner img').height());
})

// 轮播图
var bannerTimer = setInterval(BannerFunc,3000),
    bannerIndex = 0,
    banenrFlag = true;
function BannerFunc(){
    if(bannerIndex == 3){
        bannerIndex = 0;
    }else{
        bannerIndex++;
    }
    goIndex(bannerIndex);
}
function goIndex(index){
    $('.banner-list li').removeClass('active');
    $('.page-list li').removeClass('active');
    $('.banner-list li').eq(index).addClass('active');
    $('.page-list li').eq(index).addClass('active');
}
$('.banner .next').on('click', BannerFunc);
$('.banner .prev').on('click', function(){
    if(bannerIndex == 0){
        bannerIndex = 3;
    }else{
        bannerIndex--;
    }
    goIndex(bannerIndex);
});
function myClear(){
    clearInterval(bannerTimer);
    bannerFlag = true;
}
function mySet(){
    if(bannerFlag){
        bannerFlag = false;
        bannerTimer = setInterval(BannerFunc,2000);
    }
}
$('.banner .next').mouseenter(myClear);
$('.banner .prev').mouseenter(myClear);
$('.banner .next').mouseout(mySet);
$('.banner .prev').mouseout(mySet);
$('.page-list li').mouseout(mySet);
$('.page-list li').mouseenter(function(){
    myClear();
    bannerIndex = $(this).index()
    goIndex(bannerIndex);
});

//新闻资讯
for (var i = 0; i < 3; i++) {
    $('.new-show .content').eq(i).html($('.new-show .content').eq(i).html().substring(0, 150) + "……");
}

//退出登录
$(document).on('click', '.logout', function () {
    $.ajax({
        url: '/UserInfo/Logout',
        type: 'post',
        success: function(data){
            if (data == "success") {
                $('.head-image').html('<a href="../UserInfo/Index"><img src="../Content/images/headImage1.png" alt=""></a>');
            }
        }
    });
});

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