function Popup(alertClass, title, message) {
    $("#right-column").append(
        `<div class="alert ${alertClass}">
            <strong>${title}</strong> ${message}
        </div>`);

    $(".alert").delay(2200).slideUp(200, function () {
        $(this).alert('close');
    });
}

function ExceptionPopup(exceptionXhr) {
    Popup("alert-danger", "Error!", exceptionXhr.responseJSON["ExceptionMessage"]);
}

function UpdateCartItems(number) {
    $("#cart-items-number").text(number);
    $("#cart-items-number").change();
}

$(function () {
    let cartItems = $("#cart-items-number");
    cartItems.change(function () {
        cartItems.removeClass("animate-pop");
        void cartItems[0].offsetWidth; // necessary to reset the animation
        cartItems.addClass("animate-pop");
    });
});