var uc = uc || {};

uc.card = {
  init: function () {
    $(".btn-addCard").on("click", function (e) {
      e.preventDefault;
      $(".userPage_addCardForm").slideToggle();
    })

    var owl = $('.owl-carousel');
    owl.owlCarousel({
      margin: 10,
      loop: true,
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
  }
};

$(function () {
  uc.card.init();
});