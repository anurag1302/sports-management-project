
function displayPopup(response, title) {
    let modal = $("#modalPopup");
    modal.find("div.modal-body").html(response);
    modal.find("h4.modal-title").html(title);
    modal.modal("show");
}

function displayLoader() {
    $('.loader-container').addClass('show');
}

function hideLoader() {
    $('.loader-container').removeClass('show');
}
