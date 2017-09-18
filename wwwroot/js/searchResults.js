$(function () {
    function processSearchResults(data) {
        // TODO: load search results into div
    }

    function searchForLatinWord(searchString) {
        $.post("/searchLatinWord", {
            word: searchString
        }, function (data) {
            processSearchResults(data);
        }).fail(function () {
            // TODO: display error message
        });
    }

    function autoCompleteSearch(searchString) {
        // TODO: autocomplete while searching
    }
});
