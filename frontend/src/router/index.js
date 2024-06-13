import { createRouter, createWebHistory } from 'vue-router';
import HomeView from '../views/HomeView.vue';
import ReservationView from '../views/ReservationView.vue';
import FacilityAreasView from '../views/FacilityAreasView.vue';
// import AreaReservationDetailedView from '../views/AreaReservationDetailedView.vue';
const AreaReservationDetailedView = () => import('../views/AreaReservationDetailedView.vue');


const routes = [
    {
        path: '/',
        name: 'Home',
        component: HomeView
    },
    {
        path: '/reserve-area',
        name: 'ReserveArea',
        component: ReservationView
    },
    {
        path: '/reserve-area/:facilityId',
        name: 'FacilityAreas',
        component: FacilityAreasView,
    },
    {
        path: '/reserve-area/:facilityId/area/:areaId',
        name: 'AreaReservationDetailedView',
        component: AreaReservationDetailedView,
    },
];

const router = createRouter({
    history: createWebHistory(),
    routes
});

export default router;
