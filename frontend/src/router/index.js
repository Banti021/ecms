import { createRouter, createWebHistory } from 'vue-router';
import { useAuthStore } from '../store/auth';
import HomeView from '../views/HomeView.vue';
import ReservationView from '../views/ReservationView.vue';
import EventsView from '../views/EventsView.vue';
import EventDetailedView from '../views/EventDetailedView.vue';
import FacilityAreasView from '../views/FacilityAreasView.vue';
import UserProfile from '../views/UserProfile.vue';
const AreaReservationDetailedView = () => import('../views/AreaReservationDetailedView.vue');
const LoginView = () => import('../views/LoginView.vue');
const RegisterView = () => import('../views/RegisterView.vue');

const routes = [
    {
        path: '/',
        name: 'Home',
        component: HomeView
    },
    {
        path: '/reserve-area',
        name: 'ReserveArea',
        component: ReservationView,
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
        path: '/events',
        name: 'Events',
        component: EventsView,
    },
    {
        path: '/events/:eventId',
        name: 'EventDetailedView',
        component: EventDetailedView,
    },
    {
        path: '/profile',
        name: 'UserProfile',
        component: UserProfile,
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
    const authStore = useAuthStore();

    if (to.matched.some(record => record.meta.requiresAuth) && !authStore.isAuthenticated) {
        next({ name: 'Login' });
    } else {
        next();
    }
});

export default router;