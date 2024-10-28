//**GLOBAL**

//Dropdown
$('.dropdown-menu').click(function (e) {
	e.stopPropagation();
});
$(".drp-arrow").click(function () {
	$(this).parent().toggleClass("show-drop");
})
//Dropdown END

//Scroll to Top
$(window).scroll(function () {
	if ($(this).scrollTop() >= 50) {
		$('.scroll-to-top').addClass("in");
	} else {
		$('.scroll-to-top').removeClass("in");
	}
});
$('.scroll-to-top').click(function () {
	$('body,html').animate({
		scrollTop: 0
	}, 500);
});
//Scroll to Top END

//menu-fix
$(window).scroll(function (e) {
	//let scroller_anchor = $(".scroller_anchor").offset().top;
	//if ($(this).scrollTop() >= scroller_anchor && $('.scroller_anchor').css('position') !=
	//	'fixed') {
	//	$('header,.header-sec').addClass('menu-fix').slideDown();
	//} else if ($(this).scrollTop() < scroller_anchor && $('.scroller_anchor').css('position') !=
	//	'relative') {
	//	$('header,.header-sec').removeClass('menu-fix');
	//}

	var nav = $('.scroller_anchor');
	if (nav.length) {
		let scroller_anchor = $(".scroller_anchor").offset().top;
		if ($(this).scrollTop() >= scroller_anchor && $('.scroller_anchor').css('position') !=
			'fixed') {
			$('header,.header-sec').addClass('menu-fix').slideDown();
		} else if ($(this).scrollTop() < scroller_anchor && $('.scroller_anchor').css('position') !=
			'relative') {
			$('header,.header-sec').removeClass('menu-fix');
		}  
    }	
});
//menu-fix END

// custom wow
function handleIntersection(entries, observer) {
	entries.forEach(entry => {
		if (entry.isIntersecting) {
			entry.target.classList.add('animated');
			observer.unobserve(entry.target);
		}
	});
}
const observer = new IntersectionObserver(handleIntersection, {
	root: null,
	rootMargin: '0px',
	threshold: 0.2,
});
const animateElements = document.querySelectorAll('.custom-wow');
animateElements.forEach(element => {
	observer.observe(element);
});
// custom wow END

//Scroll to Relative anchor
$(document).ready(function () {
	$('a[data-anchor="relativeanchor"]').click(function () {
		var target = $(this.hash);
		$('html,body').stop().animate({
			scrollTop: target.offset().top - 100
		}, 1100);
	});
	if (location.hash) {
		var id = $(location.hash);
	}
	$(window).on('load', function () {
		if (location.hash) {
			$('html,body').animate({
				scrollTop: id.offset().top - 100
			}, 1100)
		};
	});
});
//Scroll to Relative anchor END


//**GLOBAL END**


//range slider used on search page
document.addEventListener("DOMContentLoaded", function () {
	let allRanges = document.querySelectorAll(".range-wrap");
	allRanges.forEach((wrap) => {
		let range = wrap.querySelector(".range");
		let bubble = wrap.querySelector(".bubble");

		range.addEventListener("input", () => setBubble(range, bubble));
		setBubble(range, bubble);
	});

	function setBubble(range, bubble) {
		let val = range.value;
		let min = range.min || 0;
		let max = range.max || 100;
		let newVal = ((val - min) * 100) / (max - min);
		bubble.textContent = val;
		bubble.style.left = `calc(${newVal}% + (${8 - newVal * 0.15}px))`;
	}
});
//range slider used on search page END

//Alphabet Filter used on specility page
$(document).ready(function () {
	$(".state-list .check-list li").show();
	$(".state-list .nav-link").on("click", function () {
		let selectedAlphabet = $(this).text().trim().charAt(0).toLowerCase();
		$(".state-list .check-list li").hide();
		if (selectedAlphabet === "all") {
			$(".state-list .check-list li").show();
			if ($(".state-list .check-list li:visible").length === 0) {
				/*displayNoSpecialtiesMessage();*/
			} else {
				hideNoSpecialtiesMessage();
			}
		} else {
			let $selectedSpecialties = $(".state-list .check-list li a").filter(function () {
				return $(this).text().trim().charAt(0).toLowerCase() === selectedAlphabet;
			}).parent();
			$selectedSpecialties.show();
			if ($selectedSpecialties.length === 0) {
				/*displayNoSpecialtiesMessage();*/
			} else {
				hideNoSpecialtiesMessage();
			}
		}
	});
	$("#all-tab").on("click", function () {
		$(".state-list .check-list li").show();
		hideNoSpecialtiesMessage();
	});

	function displayNoSpecialtiesMessage() {
		if ($("#no-specialties-message").length === 0) {
			let message = $("<h2>").text("Specialty not found.");
			message.attr("id", "no-specialties-message");
			message.attr("class", "sub-heading text-center");
			$(".page_list").append(message);
		}
	}
	function hideNoSpecialtiesMessage() {
		$("#no-specialties-message").remove();
	}
});
//Alphabet Filter used on specility page END



// tabs-js used in blog inner pages
(function ($) {
	$(function () {
		$(document).off('click.bs.tab.data-api', '[data-hover="tab"]');
		$(document).on('mouseenter.bs.tab.data-api', '[data-toggle="tab"], [data-hover="tab"]', function () {
			$(this).tab('show');
		});
	});
})($);

$('.tabsfilter').mouseleave(function () {
	$('.tabsfilter .tab-pane').removeClass("active");
	$('.tabsfilter .nav-link').removeClass("active");
});
// tabs-js used in blog inner pages END








// First let's set the colors of our sliders
const settings = {
	fill: '#253863',
	background: '#d7dcdf'
}
const sliders = document.querySelectorAll('.range-slider');

Array.prototype.forEach.call(sliders, (slider) => {

	slider.querySelector('input').addEventListener('input', (event) => {

		slider.querySelector('span').innerHTML = event.target.value;

		applyFill(event.target);
	});
	applyFill(slider.querySelector('input'));
});

function applyFill(slider) {
	const percentage = 100 * (slider.value - slider.min) / (slider.max - slider.min);

	const bg = `linear-gradient(90deg, ${settings.fill} ${percentage}%, ${settings.background} ${percentage + 0.1}%)`;
	slider.style.background = bg;
}

// doctors-reviews carousel

$('.doctors-reviews').owlCarousel({
	loop: false,
	margin: 20,
	autoplay: true,
	autoplayTimeout: 6000,
	nav: true,
	dots: false,
	smartSpeed: 1000,
	responsiveClass: true,
	navText: ["<i class='far fa-long-arrow-left'></i>", "<i class='far fa-long-arrow-right'></i>"],
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


$('.recent_post_slide').owlCarousel({
	loop: true,
	margin: 15,
	autoplay: true,
	autoHeight: true,
	stagePadding: 1,
	autoplayTimeout: 4000,
	nav: false,
	dots: false,
	smartSpeed: 1000,
	responsive: {
		0: {
			items: 1
		},
		600: {
			items: 2
		},
		1200: {
			items: 3
		},

	}
});
// doctors-reviews carousel end


//Tooltip
var tooltipTriggerList = [].slice.call(document.querySelectorAll('[data-bs-toggle="tooltip"]'))
var tooltipList = tooltipTriggerList.map(function (tooltipTriggerEl) {
	return new bootstrap.Tooltip(tooltipTriggerEl)
})




