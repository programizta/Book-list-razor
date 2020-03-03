﻿var dataTable;

$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#DT_load').DataTable({
        "ajax": {
            "url": "/api/book",
            "type": "GET",
            "datatype": "json"
        },
        "columns": [
            { "data": "title", "width": "20%" },
            { "data": "author", "width": "20%" },
            { "data": "isbn", "width": "20%" },
            {
                "data": "bookId",
                "render": function (data) {
                    return `<div class="text-center">
                        <a href="/BookList/UpsertBook?id=${data}" class='btn btn-success text-white' style='cursor:pointer; width:70px;'>
                            Edit
                        </a>
                        &nbsp;
                        <a class='btn btn-danger text-white' style='cursor:pointer; width:70px;'
                            onclick=Delete('/api/book?id='+${data})>
                            Delete
                        </a>
                        </div>`;
                }, "width": "40%"
            }
        ],
        "language": {
            "emptyTable": "No data found"
        },
        "width": "100%"
    });
}

function Delete(url) {
    swal({
        title: "Are you sure to delete this book?",
        text: "Once deleted, you won't be able to undo this operation.",
        icon: "warning",
        dangerMode: true,
        buttons: true,
    }).then((willDelete) => {
        if (willDelete) {
            $.ajax({
                type: "DELETE",
                url: url,
                success: function (data) {
                    if (data.success) {
                        toastr.success(data.message),
                            dataTable.ajax.reload();
                    }
                    else {
                        toastr.error(data.message);
                    }
                }
            });
        }
    });
}