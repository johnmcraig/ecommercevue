import Vue from 'vue'
import Router from 'vue-router'
import Home from '../components/Home'
import UserList from '../components/UserList'
import NotFound from '../components/error-pages/NotFound'

Vue.use(Router)

const routes = [
    { path: '/', name: 'Home', component: Home },
    { path: '/Users', name: 'Users', component: UserList },
    { path: '*', name: 'Error', component: NotFound }
  ]

export default new Router({
    mode: 'history',
    routes
  })