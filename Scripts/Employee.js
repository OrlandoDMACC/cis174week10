function searchEmployee() {
    var search = $("#searchString").val();

    $.ajax({
        url: "Search",
        data: { searchString: search }
    }).done(function (data) {
        $("#EmployeeId").val(data.EmployeeId);
        $("#EmployeeFirstName").val(data.EmployeeFirstName);
        $("#EmployeeLastName").val(EmployeeLastName);
        $("#middleName").val(middleName);
        $("#birthDate").val(birthDate);
        $("#HireDate").val(HireDate);
        $("#Department").val(Department);
        $("#JobTitle").val(JobTitle);
        $("#salary").val(salary);
        $("#AvailableHours").val(AvailableHours);

    });
}

function updateEmployee() {
    var EmployeeId = $("#EmployeeId").val();
    var EmployeeFirstName = $("#EmployeeFirstName").val();
    var EmployeeLastName = $("#EmployeeLastName").val();
    var middleName = $("#middleName").val();
    var birthDate = $("#birthDate").val();
    var HireDate = $("#HireDate").val();
    var Department = $("#Department").val();
    var JobTitle = $("#JobTitle").val();
    var salary = $("#salary").val();
    var AvailableHours = $("#AvailableHours").val();

    $.ajax({
        url: "UpdateStudent",
        dataType: "json",
        data: {
            EmployeeId: EmployeeId,
            EmployeeFirstName: EmployeeFirstName,
            EmployeeLastName: EmployeeLastName,
            middleName: middleName,
            birthDate: birthDate,
            HireDate: HireDate,
            Department: Department,
            JobTitle: JobTitle,
            salary: salary,
            AvailableHours: AvailableHours,

        }
    }).done(function (data) {
        if (data) {
            $("#successMessage").removeClass("hidden")
                .addClass("visible");
        } else {
            $("#errorMessage").removeClass("hidden")
                .addClass("visible");
        }
    });
}