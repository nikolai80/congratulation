cu.addCongratulateUser = {
  init: function () {
    $(".addCongratulateUserBtn--showHideForm").on("click", cu.addCongratulateUser.addCongratulateUserBtnClick());
  }
  , addCongratulateUserBtnClick: function () {
    $(".form-addCongratulateUser").slideToggle();
  }
}