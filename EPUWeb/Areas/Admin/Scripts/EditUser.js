$(document).ready(function () {
    $.getJSON('/Admin/User/LoadDepartment', function (data) {
        $('#DepartmentId').select2({
            data: data.lstDpjson
        });
        $("#DepartmentId").select2('val', $('#DepartmentIdold').val().toString());
    });

    $.getJSON('/Admin/User/LoadRole', function (data) {
        $('#RoleId').select2({
            data: data.lstRolejson
        });
        $("#RoleId").select2('val', $('#RoleIdold').val().toString());
    });
});