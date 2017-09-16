var uc = uc || {};

uc.card = {
  init: function () {
    $(".btn-addCard").on("click", function (e) {
      e.preventDefault;
      $(".userPage_addCardForm").slideToggle();
    })
  }
};

$(function () {
  uc.card.init();
});