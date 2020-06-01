$(document).ready(function () {

    $(document)
        .off('click', '[data-attr="sportsPersons"]')
        .on('click', '[data-attr="sportsPersons"]', function (e) {
            e.preventDefault();
            openSportsPersonsModal();
        });

});

function openSportsPersonsModal() {
    displayLoader();
    setTimeout(function () {
        $.ajax(
            {
                url: '/Sports/ViewSportsPersons',
                type: 'GET',
                success: function (response) {
                    hideLoader();
                    displayPopup(response, "Sports Persons List");
                },
                error: function (xhr) {
                    console.log(xhr);
                    hideLoader();
                }
            }
        )
    }, 2000);
}