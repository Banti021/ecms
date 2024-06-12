import { createRouter, createWebHistory } from 'vue-router';
import HomeView from '../views/HomeView.vue';
import ReservationView from '../views/ReservationView.vue';
import FacilityAreasView from '../views/FacilityAreasView.vue';

const routes = [
    {
        path: '/',
        name: 'Home',
        component: HomeView,
    },
    {
        path: '/reserve-area',
        name: 'ReserveArea',
        component: ReservationView,
    },
    {
        path: '/reserve-area/:id',
        name: 'FacilityAreas',
        component: FacilityAreasView,
    },
];

const router = createRouter({
    history: createWebHistory(process.env.BASE_URL),
    routes,
});

export default router;
