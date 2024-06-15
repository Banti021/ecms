import { createRouter, createWebHistory } from 'vue-router';
import HomeView from '../views/HomeView.vue';
import ReservationView from '../views/ReservationView.vue';
import FacilityAreasView from '../views/FacilityAreasView.vue';
const AreaReservationDetailedView = () => import('../views/AreaReservationDetailedView.vue');
const LoginView = () => import('../views/LoginView.vue');
const RegisterView = () => import('../views/RegisterView.vue');
import { useAuthState } from '../composables/useAuthState';

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
    {
        path: '/login',
        name: 'Login',
        component: LoginView
    },
    {
        path: '/register',
        name: 'Register',
        component: RegisterView
    }
];

const router = createRouter({
    history: createWebHistory(),
    routes
});

router.beforeEach((to, from, next) => {
    const { isAuthenticated } = useAuthState();
    if (!isAuthenticated.value && to.name !== 'Login' && to.name !== 'Register') {
        next({ name: 'Login' });
    } else {
        next();
    }
});

export default router;
