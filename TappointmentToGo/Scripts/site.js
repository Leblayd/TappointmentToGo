﻿function Popup(alertClass, title, message) {
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