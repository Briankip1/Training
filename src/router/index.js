import Vue from 'vue';
import Router from 'vue-router';
import HomePage from '@/views/HomePage.vue';

Vue.use(Router);

const routes = [
  {
    path: '/',
    name: 'Home',
    component: HomePage
  },
  // Add more routes here
];

const router = new Router({
  mode: 'history',
  base: process.env.BASE_URL,
  routes
});

export default router;
