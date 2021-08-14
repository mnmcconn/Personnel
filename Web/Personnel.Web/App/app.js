(function(e){function t(t){for(var a,r,l=t[0],i=t[1],c=t[2],u=0,p=[];u<l.length;u++)r=l[u],Object.prototype.hasOwnProperty.call(o,r)&&o[r]&&p.push(o[r][0]),o[r]=0;for(a in i)Object.prototype.hasOwnProperty.call(i,a)&&(e[a]=i[a]);m&&m(t);while(p.length)p.shift()();return n.push.apply(n,c||[]),s()}function s(){for(var e,t=0;t<n.length;t++){for(var s=n[t],a=!0,l=1;l<s.length;l++){var i=s[l];0!==o[i]&&(a=!1)}a&&(n.splice(t--,1),e=r(r.s=s[0]))}return e}var a={},o={app:0},n=[];function r(t){if(a[t])return a[t].exports;var s=a[t]={i:t,l:!1,exports:{}};return e[t].call(s.exports,s,s.exports,r),s.l=!0,s.exports}r.m=e,r.c=a,r.d=function(e,t,s){r.o(e,t)||Object.defineProperty(e,t,{enumerable:!0,get:s})},r.r=function(e){"undefined"!==typeof Symbol&&Symbol.toStringTag&&Object.defineProperty(e,Symbol.toStringTag,{value:"Module"}),Object.defineProperty(e,"__esModule",{value:!0})},r.t=function(e,t){if(1&t&&(e=r(e)),8&t)return e;if(4&t&&"object"===typeof e&&e&&e.__esModule)return e;var s=Object.create(null);if(r.r(s),Object.defineProperty(s,"default",{enumerable:!0,value:e}),2&t&&"string"!=typeof e)for(var a in e)r.d(s,a,function(t){return e[t]}.bind(null,a));return s},r.n=function(e){var t=e&&e.__esModule?function(){return e["default"]}:function(){return e};return r.d(t,"a",t),t},r.o=function(e,t){return Object.prototype.hasOwnProperty.call(e,t)},r.p="/";var l=window["webpackJsonp"]=window["webpackJsonp"]||[],i=l.push.bind(l);l.push=t,l=l.slice();for(var c=0;c<l.length;c++)t(l[c]);var m=i;n.push([0,"chunk-vendors"]),s()})({0:function(e,t,s){e.exports=s("56d7")},"56d7":function(e,t,s){"use strict";s.r(t);var a=s("2b0e"),o=function(){var e=this,t=e.$createElement,s=e._self._c||t;return s("div",{attrs:{id:"app"}},[s("router-view")],1)},n=[],r=s("bc3a"),l=s.n(r),i="api/",c={employees:{list:function(e){return l.a.get(i+"employeesbymanagerid/"+e)},listManagers:function(){return l.a.get(i+"managers")},create:function(e){return l.a.post(i+"employee",e)}},roles:{list:function(){return l.a.get(i+"roles")}}},m={name:"app",components:{}},u=m,p=s("2877"),d=Object(p["a"])(u,o,n,!1,null,null,null),f=d.exports,v=s("8c4f"),y=function(){var e=this,t=e.$createElement,s=e._self._c||t;return s("div",{staticClass:"container-fluid"},[s("div",{staticClass:"card"},[s("div",{staticClass:"card-heading"},[s("div",{staticClass:"row margin-bottom-40"},[s("div",{attrs:{align:"center"}},[s("div",{staticClass:"form-group",attrs:{align:"center"}},[s("h2",{directives:[{name:"show",rawName:"v-show",value:!e.listMode,expression:"!listMode"}]},[e._v("Add New Employee")])])])]),s("form",{staticClass:"form-horizontal",attrs:{role:"form"}},[s("div",{staticClass:"form-group"},[s("label",{staticClass:"col-sm-offset-2 col-sm-2 control-label",attrs:{lead:""}},[e._v("Manager:")]),s("div",{staticClass:"col-sm-8"},[s("select",{directives:[{name:"model",rawName:"v-model",value:e.manager,expression:"manager"}],staticClass:"form-control",on:{change:[function(t){var s=Array.prototype.filter.call(t.target.options,function(e){return e.selected}).map(function(e){var t="_value"in e?e._value:e.value;return t});e.manager=t.target.multiple?s:s[0]},function(t){e.managerChange()}]}},e._l(e.managers,function(t){return s("option",{key:t.EmployeeID,domProps:{value:t}},[e._v(e._s(t.DisplayName))])}))])])])]),e.listMode?s("div",{staticClass:"card-body"},[s("div",{staticClass:"row"},[s("div",{staticClass:"col-sm-offset-2 col-sm-8 table-responsive"},[s("table",{staticClass:"table table-striped table-condensed table-bordered table-hover small"},[e._m(0),s("tbody",e._l(e.employees,function(t){return s("tr",{key:t.EmployeeID,attrs:{value:t}},[s("td",[e._v(e._s(t.EmployeeCode))]),s("td",[e._v(e._s(t.LastName))]),s("td",[e._v(e._s(t.FirstName))])])}))])])]),s("div",{staticClass:"row"},[s("div",{staticClass:"col-sm-offset-5 col-sm-2"},[s("div",{staticClass:"form-group"},[s("button",{staticClass:"btn btn-sm btn-primary",attrs:{type:"button","aria-label":"Add Employee"},on:{click:function(t){e.listMode=!e.listMode}}},[s("span",{staticClass:"fa fa-add",attrs:{"aria-hidden":"true"}},[e._v(" Add Employee")])])])])])]):s("div",{staticClass:"card-body"},[s("form",{staticClass:"form-horizontal",attrs:{role:"form"}},[s("div",{staticClass:"form-group"},[s("label",{staticClass:"col-sm-offset-2 col-sm-2 control-label"},[e._v("Employee ID:")]),s("div",{staticClass:"col-sm-8"},[s("input",{directives:[{name:"model",rawName:"v-model",value:e.employee.EmployeeCode,expression:"employee.EmployeeCode"}],staticClass:"form-control",attrs:{type:"text"},domProps:{value:e.employee.EmployeeCode},on:{input:function(t){t.target.composing||e.$set(e.employee,"EmployeeCode",t.target.value)}}})])]),s("div",{staticClass:"form-group"},[s("label",{staticClass:"col-sm-offset-2 col-sm-2 control-label"},[e._v("First Name:")]),s("div",{staticClass:"col-sm-8"},[s("input",{directives:[{name:"model",rawName:"v-model",value:e.employee.FirstName,expression:"employee.FirstName"}],staticClass:"form-control",attrs:{type:"text"},domProps:{value:e.employee.FirstName},on:{input:function(t){t.target.composing||e.$set(e.employee,"FirstName",t.target.value)}}})])]),s("div",{staticClass:"form-group"},[s("label",{staticClass:"col-sm-offset-2 col-sm-2 control-label"},[e._v("Last Name:")]),s("div",{staticClass:"col-sm-8"},[s("input",{directives:[{name:"model",rawName:"v-model",value:e.employee.LastName,expression:"employee.LastName"}],staticClass:"form-control",attrs:{type:"text"},domProps:{value:e.employee.LastName},on:{input:function(t){t.target.composing||e.$set(e.employee,"LastName",t.target.value)}}})])]),s("div",{staticClass:"form-group"},[s("label",{staticClass:"col-sm-offset-2 col-sm-2 control-label"},[e._v("Roles:")]),s("div",{staticClass:"col-sm-8"},[s("select",{directives:[{name:"model",rawName:"v-model",value:e.selectedRoles,expression:"selectedRoles"}],staticClass:"form-control",attrs:{multiple:""},on:{change:function(t){var s=Array.prototype.filter.call(t.target.options,function(e){return e.selected}).map(function(e){var t="_value"in e?e._value:e.value;return t});e.selectedRoles=t.target.multiple?s:s[0]}}},e._l(e.roles,function(t){return s("option",{domProps:{value:t}},[e._v("\n                                "+e._s(t.Description)+"\n                            ")])}))])])]),s("div",{staticClass:"row"},[s("div",{staticClass:"col-sm-offset-5 col-sm-1"},[s("div",{staticClass:"form-group"},[s("button",{staticClass:"btn btn-sm btn-primary",attrs:{type:"button"},on:{click:function(t){e.addEmployee()}}},[e._v("\n                            Save\n                        ")])])]),s("div",{staticClass:"col-sm-1"},[s("div",{staticClass:"form-group"},[s("button",{staticClass:"btn btn-sm btn-primary",attrs:{type:"button"},on:{click:function(t){e.listMode=!e.listMode}}},[e._v("\n                            Cancel\n                        ")])])])])])])])},g=[function(){var e=this,t=e.$createElement,s=e._self._c||t;return s("thead",[s("tr",{staticClass:"lightgrey"},[s("td",[s("b",[e._v("Employee ID")])]),s("td",[s("b",[e._v("Last Name")])]),s("td",[s("b",[e._v("First Name")])])])])}],h=(s("55dd"),s("d4ec")),b=function e(){Object(h["a"])(this,e),this.EmployeeID=null,this.ManagerID=null,this.EmployeeCode="",this.FirstName="",this.LastName="",this.CreatedOn=null,this.Roles=[]};function C(e){return null==e?null:JSON.parse(JSON.stringify(e))}var _=s("1940"),w=s.n(_),N={name:"Personnel",data:function(){return{isLoading:!0,listMode:!0,roles:[],manager:null,managers:[],employee:new b,employees:[],selectedRoles:[]}},mounted:function(){this.getManagers(),this.getRoles()},methods:{getManagers:function(){var e=this;return c.employees.listManagers().then(function(t){e.managers=t.data.Data,e.managers.sort(function(e,t){return e.LastName.toLowerCase()>t.LastName.toLowerCase()?1:-1}),e.getEmployees()}).catch(function(e){console.log("error.response",e.response)})},getEmployees:function(){var e=this;return this.manager?c.employees.list(this.manager.EmployeeID).then(function(t){e.employees=t.data.Data,e.employees.sort(function(e,t){return e.LastName.toLowerCase()>t.LastName.toLowerCase()?1:-1})}):null},getRoles:function(){var e=this;return c.roles.list().then(function(t){e.roles=t.data.Data}).catch(function(e){console.log("error.response",e.response)})},addEmployee:function(){var e=this;this.employee.Roles=C(this.selectedRoles),this.valid()&&(this.employee.ManagerID=this.manager.EmployeeID,c.employees.create(this.employee).then(function(t){e.handleResponse(t)&&(w()("Success!",t.data.Message,"success"),e.employee=new b,e.selectedRoles=[],e.getManagers(),e.listMode=!e.listMode)}).catch(function(e){w()("Failure!","Add Employee Failed","warning")}))},handleResponse:function(e){return!!e.data.Success},managerChange:function(){this.getEmployees()},valid:function(){var e=[];return this.employee.EmployeeCode||e.push("Employee ID is required."),this.employee.FirstName||e.push("First Name is required."),this.employee.LastName||e.push("Last Name is required."),0==this.selectedRoles.length&&e.push("At least one role is required."),!(e.length>0)||(w()("Add Employee Failed!",e.join("\n"),"warning"),!1)}}},E=N,M=Object(p["a"])(E,y,g,!1,null,null,null),L=M.exports;a["a"].use(v["a"]);var x=new v["a"]({routes:[{path:"/",name:"Personnel",component:L}]});a["a"].config.productionTip=!0,new a["a"]({router:x,render:function(e){return e(f)}}).$mount("#app")}});
//# sourceMappingURL=app.js.map