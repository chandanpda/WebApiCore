

$(".navbar-toggler").click(function () {
    $(".popup-backdrop").toggleClass("popup-backdrop-in");
});

$(window).scroll(function (e) {
    var scroller_anchor = $(".scroller_anchor").offset().top;
    if ($(this).scrollTop() >= scroller_anchor && $('.scroller_anchor').css('position') != 'fixed') {
        $('.header-sec').addClass('menu-fix').slideDown();
    } else if ($(this).scrollTop() < scroller_anchor && $('.scroller_anchor').css('position') !=
        'relative') {
        $('.header-sec').removeClass('menu-fix');
    }
});


// Add minus icon for collapse element which is open by default
$(".collapse.show").each(function () {
    $(this)
        .prev(".card-header")
        .find(".fa-solid")
        .addClass("fa-minus")
        .removeClass("fa-plus");
});

// Toggle plus minus icon on show hide of collapse element
$(".collapse").on("show.bs.collapse", function () {
    $(this)
        .prev(".card-header")
        .find(".fa-solid")
        .removeClass("fa-plus")
        .addClass("fa-minus");
})
.on("hide.bs.collapse", function () {
    $(this)
        .prev(".card-header")
        .find(".fa-solid")
        .removeClass("fa-minus")
        .addClass("fa-plus");
});


$('#doctors-reviews').owlCarousel({
    loop: false,
    margin: 20,
    autoplay: true,
    autoplayTimeout: 6000,
    nav: true,
    dots: false,
    smartSpeed: 1000,
    responsiveClass: true,
    navText: ["<i class='fal fa-long-arrow-left'></i>", "<i class='fal fa-long-arrow-right'></i>"],
    responsive: {
        0: {
            items: 1
        },
        600: {
            items: 2
        },
        1000: {
            items: 3
        }
    }
})

