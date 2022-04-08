$(document).on('click', '#btnSave', function (e) {
    e.preventDefault();
    var spinner = $('#loader');
    var obj = {
        name: $('#Name').val()
    };
    spinner.show();
    $.ajax({
        type: 'POST',
        url: '/Loader/Loader',
        dataType: 'json',
        data: obj,
    }).done(function (response) {
        spinner.hide();
        alert(response.name);
    });

});
