//-----------------------------------
import axios from 'axios'

var apiRoot = 'api/';

export default {   
    employees: {
        list(id) { return axios.get(apiRoot + 'employeesbymanagerid/' + id); },
        listManagers() { return axios.get(apiRoot + 'managers'); },       
        create(obj) { return axios.post(apiRoot + 'employee', obj); },       
    },
    roles: {
        list() { return axios.get(apiRoot + 'roles'); },
    },   
}