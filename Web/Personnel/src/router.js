import Vue from 'vue'
import Router from 'vue-router'

import Personnel from '@/components/layouts/Personnel'

Vue.use(Router)

export default new Router({
    routes: [
        { path: '/', name: 'Personnel', component: Personnel }]
})
