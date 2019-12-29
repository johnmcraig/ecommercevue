import Vue from 'vue'
import VueRouter from 'vue-router'
import Home from '../components/Home'
import UserList from '../components/UserList'
import NotFound from '../components/error-pages/NotFound'
import Catalogue from '../pages/Catalogue.vue'
import Product from '../pages/Product.vue'


Vue.use(VueRouter)

const routes = [
    { path: '/', name: 'Home', component: Home },
    { path: '/products', name: 'Catalogue', component: Catalogue },
    { path: '/products/:slug', name: 'Product', component: Product },
    { path: '/users', name: 'Users', component: UserList },
    { path: '*', name: 'Error', component: NotFound }
  ]

export default new VueRouter({
    mode: 'history',
    routes
  })