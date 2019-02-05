function popup(alertClass, message) {
    $("#right-column").append(
        `<div class="alert ${alertClass}">
                                <strong>Success!</strong> ${message}.
                            </div>`);

    $(".alert").delay(1500).slideUp(200, function () {
        $(this).alert('close');
    });
}