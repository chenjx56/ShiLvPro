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