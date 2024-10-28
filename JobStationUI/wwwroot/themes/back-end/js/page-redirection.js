
$(function () {
    $('#page-redirection-table').DataTable({
        "columnDefs": [{
            "targets": 'no-sort',
            "orderable": false,
        }],
        "aaSorting": [[4, "desc"]],
        "pageLength": 50
    });
});

$(document).on('click', '.manage-redirection', function (e) {
    
    e.preventDefault();
    var _self = $(this);

    $.ajax({
        type: "GET",
        url: '/PageRedirection/GetByGuid',
        data: {
            guid: _self.attr('data-guid')
        },
        success: function (data) {
            $('.ajax-loader').addClass('d-none');
            if (data.success) {                
                var page = data.page;
                if (page) {
                    $('#RedirectionId').val(page.id);
                    $('#OldURL').val(page.oldURL);
                    $('#NewURL').val(page.newURL);
                    $('#StatusCode').val(page.statusCode);
                    $('#StatusText').val(page.statusText);
                } else {
                    $('#CreatePageModalForm')[0].reset();
                }

                $('#CreatePageModal').modal('show');

            } else {
                toastr.error(data.msg);
            }
        },
        error: function (req, error) {
            toastr.error(req.responseText);
            $('.ajax-loader').addClass('d-none');
        },
        beforeSend: function (data) {
            $('.ajax-loader').removeClass('d-none');
        }
    });
});


$(document).on('submit', '#CreatePageModalForm', function (e) {
    
    e.preventDefault();
    var _self = $(this);
    $.ajax({
        type: _self.attr('method'),
        url: _self.attr("action"),
        data: _self.serialize(),
        success: function (data) {
            $('.ajax-loader').addClass('d-none');
            if (data.success) {
                toastr.success(data.msg);
                setTimeout(function () {
                    window.location.reload();
                }, 1000);
            } else {
                toastr.error(data.msg);
            }
        },
        error: function (req, error) {
            toastr.error(req.responseText);
            $('.ajax-loader').addClass('d-none');
        },
        beforeSend: function (data) {
            $('.ajax-loader').removeClass('d-none');
        }
    });
});

$(document).on('click', '.delete-redirection', function (e) {
    e.preventDefault();
    var _self = $(this);
    bootbox.confirm({
        title: "Confirm?",
        message: "Are you sure for this action?",
        centerVertical: false,
        buttons: {
            cancel: {
                label: '<i class="fa fa-times"></i> Cancel',
                className: 'btn-danger'
            },
            confirm: {
                label: '<i class="fa fa-check"></i> Confirm',
                className: 'btn-success'
            }
        },
        callback: function (result) {
            if (result) {
                $.ajax({
                    type: "POST",
                    url: '/PageRedirection/Delete',
                    data: {
                        guid: _self.attr('data-guid')
                    },
                    success: function (data) {
                        $('.ajax-loader').addClass('d-none');
                        if (data.success) {

                            toastr.success(data.msg);

                            setTimeout(function () {
                                window.location.reload();
                            }, 1000);

                        } else {
                            toastr.error(data.msg);
                        }

                    },
                    error: function (req, error) {
                        toastr.error(req.responseText);
                        $('.ajax-loader').addClass('d-none');
                    },
                    beforeSend: function (data) {
                        $('.ajax-loader').removeClass('d-none');
                    }
                });

            }
        }
    });
});