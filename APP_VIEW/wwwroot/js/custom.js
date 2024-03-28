// custom.js

// Định nghĩa hàm initSlickCarousel
function initSlickCarousel() {
    $('#carousel-related-product').slick({
        infinite: true,
        arrows: false,
        slidesToShow: 4,
        slidesToScroll: 3,
        dots: true,
        responsive: [{
            breakpoint: 1024,
            settings: {
                slidesToShow: 3,
                slidesToScroll: 3
            }
        },
        {
            breakpoint: 600,
            settings: {
                slidesToShow: 2,
                slidesToScroll: 3
            }
        },
        {
            breakpoint: 480,
            settings: {
                slidesToShow: 2,
                slidesToScroll: 3
            }
        }]
    });
}

// Gọi hàm initSlickCarousel khi tài liệu HTML đã sẵn sàng
$(document).ready(function () {
    initSlickCarousel();
});
