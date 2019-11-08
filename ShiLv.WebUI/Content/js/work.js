$(function(){
    //轮播图动态大小调整
    function PageInit(){
        if($(window).width()>=1180){
            $('.lunbo-box .lunbo img').width($(window).width());
        }
        else{
            $('.lunbo-box .lunbo img').width(1180);
        }
        $('.lunbo-box .lunbo').width(5*$('.lunbo-box .lunbo img').width());
    }
    var brforeDocWidth = $(document).width();
    $(window).resize(function(){
        PageInit();        
    });       
    $(document).add(window).resize(function(){
        var docWidth = $(document).width();
        var index = $('.lunbo-box .lunbo li').filter(function(tag){
            return ($(this).offset().left>-500 && $(this).offset().left<=brforeDocWidth+60);
        }).index();  
        if($(document).width()>$(window).width()){
            $('.lunbo-box .lunbo').css({'left':'-'+index*docWidth+'px'});         
        }
        else{
            $('.lunbo-box .lunbo').css({'left':'-'+index*docWidth+'px'});
        }
        brforeDocWidth = docWidth;   
        // $('.nav-wrapper .search-show').animate({
        //     right:'5px',
        //     top:'15px'
        // },function () {
        //     $('.lunbo-box .search-filter').fadeOut();
        // });
        
        if($('.lunbo-box .search-filter').css('display') == 'block'){
            var width = $(document).width()>$(window).width()? $(document).width():$(window).width();
            var height = $('.lunbo-box img').eq(0).height();
            height = height/2+65;
            width=width/2-340;
            $('.nav-wrapper .search-show').css({
                right:width+'px',
                top:height+'px'
            });
        }
        
    })
    PageInit();
    
    //轮播图功能代码
    
    var lunboTimer = null;
    var when = 0;
    function autoLunbo(){
        var imgWidth = $('.lunbo-box .lunbo img').eq(0).width();
        if(Math.abs(parseInt($('.lunbo-box .lunbo').css('left'))) >= 4*imgWidth){
            $('.lunbo-box .lunbo').css('left','0');
        }
        if(when == 0){
            $('.lunbo-box .lunbo').animate({left:'-='+imgWidth+'px'},buttonResponserespond);
        }
        else $('.lunbo-box .lunbo').animate({left:'-='+imgWidth+'px'},buttonResponserespond);
        when++; 
    }
    lunboTimer =setInterval(autoLunbo,3000);
    var mutexMouse = false;
    $('.lunbo-box').add('.lunbo-icon').add('.arrow-box').mouseenter(function () { 
        mutexMouse = true;
        clearInterval(lunboTimer);
    });
    $('.lunbo-box').add('.lunbo-icon').add('.arrow-box').mouseleave(function () { 
        if(mutexMouse){
            lunboTimer = setInterval(autoLunbo,3000);
            mutexMouse = false
        }    
    });
    var clickMutex = true;
    $('.lunbo-box .arrow-box .right-arrow').click(function () {
        if(clickMutex){
            clickMutex = false
            var imgWidth = $('.lunbo-box .lunbo img').eq(0).width();
            if(Math.abs(parseInt($('.lunbo-box .lunbo').css('left'))) >= 4*imgWidth){
                $('.lunbo-box .lunbo').css('left','0');
            }
            var index = Math.abs(parseInt($('.lunbo-box .lunbo').css('left'))) / imgWidth;
                $('.lunbo-box .lunbo').animate({'left':'-'+(index+1)*imgWidth+'px'},function(){
                clickMutex = true;
                buttonResponserespond();
            })
        }   
    });
    $('.lunbo-box .arrow-box .left-arrow').click(function () {
        if(clickMutex){
            clickMutex = false
            var imgWidth = $('.lunbo-box .lunbo img').eq(0).width();
            if(Math.abs(parseInt($('.lunbo-box .lunbo').css('left'))) == 0){
                $('.lunbo-box .lunbo').css('left','-'+4*imgWidth+'px');
            }
            var index = Math.abs(parseInt($('.lunbo-box .lunbo').css('left'))) / imgWidth;
                $('.lunbo-box .lunbo').animate({'left':'-'+(index-1)*imgWidth+'px'},function(){
                clickMutex = true;
                buttonResponserespond();
            })
        }   
    });
    $('.lunbo-box .lunbo-icon li').click(function(){
        var imgWidth = $('.lunbo-box .lunbo img').eq(0).width();
        $('.lunbo-box .lunbo-icon li').css('color','black');
        var index =$(this).css('color','green').index();
        $('.lunbo-box .lunbo').animate({'left':'-'+index*imgWidth+'px'})
    });
    function buttonResponserespond(){
        var imgWidth = $('.lunbo-box .lunbo img').eq(0).width();
        var index = Math.abs(parseInt($('.lunbo-box .lunbo').css('left'))) / imgWidth;
        if(index == 4) index = 0;
        $('.lunbo-box .lunbo-icon li').css('color','black');
        $('.lunbo-box .lunbo-icon li').eq(index).css('color','green');
    }
    buttonResponserespond();
    //搜索
    $('.nav-wrapper .search-show').css('display','block')
    $('.nav-wrapper .search-show').click(function(){
        var width = $(document).width()>$(window).width()? $(document).width():$(window).width();
        var height = $('.lunbo-box img').eq(0).height();
        height = height/2+65;
        width=width/2-340;
        $(this).animate({
            right:width+'px',
            top:height+'px'
        },function(){
            $('.lunbo-box .search-filter').fadeIn();
        });
    });
    $('.lunbo-box .search-filter .shut-search').click(function(e){
        e.stopPropagation();
        $('.lunbo-box .search-filter').fadeOut();
        $('.nav-wrapper .search-show').animate({
            right:'5px',
            top:'15px'
        });
    });
    //作品图片悬浮放大
    $('.work-detail-box .show-detail img').attr('src', $('.work-detail-box .works-img').eq(0).children('img').attr('src'));
    $(".work-detail-box .works-img").hover(function(){
        $(this).children('img').stop(true).animate({
            width:'300px',
            height:'300px',
            left:'-25px',
            top:'-25px'
        },200);
        $(this).children('.hand-works-intro').children('.intro-text').stop(true).animate({'bottom':'-50px'},400);
        $(this).children('.text-filter').stop(true).fadeIn(400);
        $('.work-detail-box .show-detail img').attr('src', $(this).children('img').attr('src'));
    },function(){
        $(this).children('img').animate({
            width:'250px',
            height:'250px',
            left:'0px',
            top:'0px'
        });
        $(this).children('.hand-works-intro').children('.intro-text').animate({'bottom':'0'},200);
        $(this).children('.text-filter').fadeOut(400);
        });

    $('body').on('click', '.gray-bg .remove', function () {
        $('.gray-bg').remove();
        $('.pic-detail').remove();
    })
    
})
$('.works-img').click(function () {
    console.log($(this).attr('id'));
    $.ajax({
        url: '../WorkHome/GetWorkDetails',
        type: 'post',
        data: {
            ArtefactsID : $(this).attr('id')
        },
        success: function (data) {
            $('body').append(data);
        }
    });
});