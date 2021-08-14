<template>
    <div class="container-fluid">
        <div class="card">
            <div class="card-heading">
                <div class="row margin-bottom-40">
                    <div align="center">
                        <div class="form-group" align="center">
                            <h2 v-show="!listMode">Add New Employee</h2>
                        </div>
                    </div>
                </div>
                <form class="form-horizontal" role="form">
                    <div class="form-group">
                        <label lead class="col-sm-offset-2 col-sm-2 control-label">Manager:</label>
                        <div class="col-sm-8">
                            <select class="form-control" v-model="manager" @change="managerChange()">
                                <option v-for="x in managers" :key="x.EmployeeID" :value="x">{{x.DisplayName}}</option>
                            </select>
                        </div>
                    </div>
                </form>
            </div>
            <div v-if="listMode" class="card-body">
                <div class="row">
                    <div class="col-sm-offset-2 col-sm-8 table-responsive">
                        <table class="table table-striped table-condensed table-bordered table-hover small">
                            <thead>
                                <tr class="lightgrey">
                                    <td><b>Employee ID</b></td>
                                    <td><b>Last Name</b></td>
                                    <td><b>First Name</b></td>
                                </tr>
                            </thead>
                            <tbody>
                                <tr v-for="e in employees" :key="e.EmployeeID" :value="e">
                                    <td>{{e.EmployeeCode}}</td>
                                    <td>{{e.LastName}}</td>
                                    <td>{{e.FirstName}}</td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                </div>
                <div class="row">
                    <div class="col-sm-offset-5 col-sm-2">
                        <div class="form-group">
                            <button type="button" class="btn btn-sm btn-primary" @click="listMode=!listMode" aria-label="Add Employee">
                                <span class="fa fa-add" aria-hidden="true"> Add Employee</span>
                            </button>
                        </div>
                    </div>
                </div>
            </div>
            <div v-else class="card-body">
                <form class="form-horizontal" role="form">
                    <div class="form-group">
                        <label class="col-sm-offset-2 col-sm-2 control-label">Employee ID:</label>
                        <div class="col-sm-8">
                            <input type="text" class="form-control" v-model="employee.EmployeeCode">
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-offset-2 col-sm-2 control-label">First Name:</label>
                        <div class="col-sm-8">
                            <input type="text" class="form-control" v-model="employee.FirstName">
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-offset-2 col-sm-2 control-label">Last Name:</label>
                        <div class="col-sm-8">
                            <input type="text" class="form-control" v-model="employee.LastName">
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-offset-2 col-sm-2 control-label">Roles:</label>
                        <div class="col-sm-8">
                            <select class="form-control" v-model="selectedRoles" multiple>
                                <option v-for="r in roles" v-bind:value="r">
                                    {{ r.Description }}
                                </option>
                            </select>
                        </div>
                    </div>
                </form>

                <div class="row">
                    <div class="col-sm-offset-5 col-sm-1">
                        <div class="form-group">
                            <button type="button" class="btn btn-sm btn-primary" @click="addEmployee()">
                                Save
                            </button>
                        </div>
                    </div>
                    <div class="col-sm-1">
                        <div class="form-group">
                            <button type="button" class="btn btn-sm btn-primary" @click="listMode=!listMode; ;">
                                Cancel
                            </button>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</template>

<script>
    import repo from "@/utils/repo";
    import Employee from "../../models/Employee";
    import * as Clone from '@/utils/clone';
    import swal from "sweetalert"
    export default {
        name: "Personnel",
        data() {
            return {
                isLoading: true,
                listMode: true,

                roles: [],

                manager: null,
                managers: [],

                employee: new Employee(),
                employees: [],
                selectedRoles: [],

            }
        },
        mounted() {
            this.getManagers();
            this.getRoles();
        },

        methods: {

            getManagers() {
                return repo.employees.listManagers().then(res => {
                    this.managers = res.data.Data;
                    this.managers.sort((a, b) => (a.LastName.toLowerCase() > b.LastName.toLowerCase()) ? 1 : -1)
                    this.getEmployees();
                }).catch(error => {
                    console.log('error.response', error.response);
                });
            },

            getEmployees() {

                if (!this.manager) {
                    return null;
                }

                return repo.employees.list(this.manager.EmployeeID).then(res => {
                    this.employees = res.data.Data;
                    this.employees.sort((a, b) => (a.LastName.toLowerCase() > b.LastName.toLowerCase()) ? 1 : -1)
                });
            },

            getRoles() {

                return repo.roles.list().then(res => {
                    this.roles = res.data.Data;
                }).catch(error => {
                    console.log('error.response', error.response);
                });
            },

            addEmployee() {

                this.employee.Roles = Clone.json(this.selectedRoles);

                if (this.valid()) {

                    this.employee.ManagerID = this.manager.EmployeeID;
                    repo.employees.create(this.employee).then(res => {
                        if (this.handleResponse(res)) {
                            
                            swal("Success!", res.data.Message, "success");
                            this.employee = new Employee();
                            this.selectedRoles = [];
                            this.getManagers();
                            this.listMode = !this.listMode;
                        }
                    }).catch(error => {
                        swal("Failure!", "Add Employee Failed", "warning");
                    });                    
                }
            },

            handleResponse(res) {

                if (res.data.Success)
                    return true;

                return false;
            },

            managerChange() {
                this.getEmployees();
            },
          
            valid() {

                var errors = [];

                if (!this.employee.EmployeeCode) {
                    errors.push('Employee ID is required.');
                }
                if (!this.employee.FirstName) {
                    errors.push("First Name is required.");
                }
                if (!this.employee.LastName) {
                    errors.push("Last Name is required.");
                }
                if (this.selectedRoles.length == 0) {
                    errors.push("At least one role is required.");
                }
                if (errors.length > 0) {
                    swal("Add Employee Failed!", errors.join('\n'), "warning");
                    return false;
                }
                return true;
            }
        }
    };
</script>

