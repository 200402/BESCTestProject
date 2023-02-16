// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

addModel = (form) => {
    var data = $(form).serialize();
    console.log(data);
    $.ajax({
        type: 'POST',
        url: '/Home/CreateModel',
        contentType: 'application/x-www-form-urlencoded; charset=UTF-8', // when we use .serialize() this generates the data in query string format. this needs the default contentType (default content type is: contentType: 'application/x-www-form-urlencoded; charset=UTF-8') so it is optional, you can remove it
        data: data,
        success: function (result) {
            console.log(result);
        },
        error: function () {
            console.log('Failed ');
        }
    });
    setTimeout(() => { location.reload(true); }, 300);
}

editModel = (id, name, active, brand, statusName) => {
    document.getElementById('IdInput').value = id;
    document.getElementById('NameText').value = name;
    document.getElementById('ActiveInput').value = active;
    document.getElementById('IdBrandSelect').value = brand;
    document.getElementById("H1Status").innerHTML = statusName;
}

deleteModel = (id) => {
    if (confirm('Вы уверены, что хотите удалить эту модель')) {
        $.ajax({
            type: 'POST',
            url: '/Home/DeleteModel',
            contentType: 'application/x-www-form-urlencoded; charset=UTF-8', // when we use .serialize() this generates the data in query string format. this needs the default contentType (default content type is: contentType: 'application/x-www-form-urlencoded; charset=UTF-8') so it is optional, you can remove it
            data: "Id=" + id,
            success: function (result) {
                console.log(result);
            },
            error: function () {
                console.log('Failed ');
            }
        });
        setTimeout(() => { location.reload(true); }, 300); 
    } 
}

addBrand = (form) => {
    var data = $(form).serialize();
    console.log(data);
    $.ajax({
        type: 'POST',
        url: '/Home/CreateBrand',
        contentType: 'application/x-www-form-urlencoded; charset=UTF-8', // when we use .serialize() this generates the data in query string format. this needs the default contentType (default content type is: contentType: 'application/x-www-form-urlencoded; charset=UTF-8') so it is optional, you can remove it
        data: data,
        success: function (result) {
            console.log(result);
        },
        error: function () {
            console.log('Failed ');
        }
    });
    setTimeout(() => { location.reload(true); }, 300);
}
editBrand = (id, name, statusName) => {

    document.getElementById('IdInput').value = id;
    document.getElementById('NameText').value = name;
    document.getElementById("H1Status").innerHTML = statusName;
}

deleteBrand = (id) => {
    if (confirm('Вы уверены, что хотите удалить эту модель')) {
        $.ajax({
            type: 'POST',
            url: '/Home/DeleteBrand',
            contentType: 'application/x-www-form-urlencoded; charset=UTF-8', // when we use .serialize() this generates the data in query string format. this needs the default contentType (default content type is: contentType: 'application/x-www-form-urlencoded; charset=UTF-8') so it is optional, you can remove it
            data: "Id=" + id,
            success: function (result) {
                console.log(result);
            },
            error: function () {
                console.log('Failed ');
            }
        });
        setTimeout(() => { location.reload(true); }, 300); 
    } 
}