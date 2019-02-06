function popup(alertClass, title, message) {
    $("#right-column").append(
        `<div class="alert ${alertClass}">
            <strong>${title}</strong> ${message}.
        </div>`);

    $(".alert").delay(1500).slideUp(200, function () {
        $(this).alert('close');
    });
}