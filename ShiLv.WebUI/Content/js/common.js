$('.nav-wrapper .nav').animate({
    width:'1180px',
    fontSize:'20px'
},600) 
$('.nav-wrapper .nav-logo').fadeIn(800,'linear',function(){
    $(this).animate({
        width: '100px',
        height: '100px',
        left: '50%',
        top: '55%', 
        marginLeft: '-50px',
        marginTop: '-50px'
    },function(){
        if($(window).width()>=1340){
            $(".nav-wrapper .user-pic").animate({
            top:'50%',
            marginTop:"-32.5px"
            },800)
        }     
    })
});  
$(window).on("resize",function(){
    if($(this).width()<=1340)
    {
        $(".nav-wrapper .user-pic").stop().animate({
            top:'-100px',
            marginTop:"-32.5px"
        },500)
    }
    if($(this).width()>1340)
    {
        if($(window).width()>1340){
            $(".nav-wrapper .user-pic").stop().animate({
            top:'50%',
            marginTop:"-32.5px"
            },800)
        }   
    }
})   