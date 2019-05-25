import Vue from 'vue'
import Router from 'vue-router'
import Home from '../components/Home'
import UserList from '../components/UserList'

Vue.use(Router)

const routes = [
    { 
      path: '/',
      name: 'Home', 
      component: Home
    },
    {
      path: '/Users',
      name: 'Users',
      component: UserList

    }
  ]

export default new Router({
    mode: 'history',
    routes
  })