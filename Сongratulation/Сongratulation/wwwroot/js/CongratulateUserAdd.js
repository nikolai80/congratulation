var cu = cu || {};

cu.addCongratulateUser = {
  init: function () {
    var that = this;
    $(".addCongratulateUserBtn--showHideForm").on("click", function () {
      $(".form-addCongratulateUser").toggle();
      that.addNewCongratulateUser();
    });
  }
  , addNewCongratulateUser: function () {
    var alias = "";
    var name = "";
    var surname = "";
    var birthdayDate = "";
    alias = $("input[name='alias']", ".form-addCongratulateUser").val();
    name = $("input[name='name']", ".form-addCongratulateUser").val();
    surname = $("input[name='surname']", ".form-addCongratulateUser").val();
    birthdayDate = $("input[name='birthdayDate']", ".form-addCongratulateUser").val();
    console.log(name || "-", alias || "-", surname || "-", birthdayDate || "-");

    if (alias != "" && name != "") {
      $.ajax({
        url: "home/CreateCongratulateUser"
        ,type:"POST"
        ,data: {
          alias: alias
          , name: name
          , surname: surname
          , birthdayDate: birthdayDate
        }
        , success: function (data) {
          console.log(data);
        } 
      })
    }
  }
}