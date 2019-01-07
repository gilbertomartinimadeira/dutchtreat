$(document).ready(function () {
    var t = 1;

    console.log('hello pluralsight ' + t);

    //var theForm = document.getElementById("theForm");
    var $theForm = $("#theForm");
    $theForm.hide();

    //var buyButton = document.getElementById("buyButton");

    var $buyButton = $("#buyButton");

    $buyButton.on("click", function () {
        console.log("buy clicked");
    });

    var $productInfoListItem = $(".product-props li");

    $productInfoListItem.on("click", function () {
        console.log("Cliquei no item " + $(this).text());
    });
});
    