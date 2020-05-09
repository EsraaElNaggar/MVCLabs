function confirmDelete(id) {
    let res = confirm("Are you sure?");
    if (res) {
        $.ajax({
            url: "/ Employees / Delete /"+id,
            type: "POST",
            success: function (response) {
                if (res) {
                    let tr = $("#"+id)
                    tr.remove();
                }
            },
            error: function (xhr, status, err) {
                console.log(error);
            }
        })
    }
}

function onSuccess() {
    document.getElementById("form0").reset();
    $("#employeeModal").modal("hide");
}
