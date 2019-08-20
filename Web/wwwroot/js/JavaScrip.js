function buttonClick() {
    $.ajax({
        url: 'https://localhost:44329/api/values/soma?n1=1&n2=2',
        method: 'GET',
        success: function (result) {
            alert(result);
        }
    });
};