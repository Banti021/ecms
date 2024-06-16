// src/store/auth.js
import { defineStore } from 'pinia';
import { ref, inject } from 'vue';
import { useRouter } from 'vue-router';

export const useAuthStore = defineStore('auth', () => {
    const router = useRouter();
    const apiClient = inject('apiClient');
    if (!apiClient) {
        throw new Error('API client is not provided');
    }

    const user = ref(null);
    const error = ref(null);
    const isAuthenticated = ref(false);

    const fetchUser = async () => {
        try {
            const response = await apiClient.get('/auth/me');
            user.value = response.data;
        } catch (err) {
            console.error('Failed to fetch user data', err);
            logout();
        }
    };

    const login = async (credentials) => {
        try {
            const response = await apiClient.post('/auth/login', credentials);
            user.value = response.data.user;
            error.value = null;
            isAuthenticated.value = true;
            localStorage.setItem('token', response.data.token); // Store token in local storage
            apiClient.defaults.headers.common['Authorization'] = `Bearer ${response.data.token}`;
            router.push({ name: 'Home' });
        } catch (err) {
            console.error('API error', err);
            error.value = err.response ? err.response.data.message : err.message;
        }
    };

    const register = async (userData) => {
        try {
            const response = await apiClient.post('/auth/register', userData);
            user.value = response.data.user;
            error.value = null;
            isAuthenticated.value = true;
            localStorage.setItem('token', response.data.token); // Store token in local storage
            apiClient.defaults.headers.common['Authorization'] = `Bearer ${response.data.token}`;
            router.push({ name: 'Home' });
        } catch (err) {
            console.error('API error', err);
            error.value = err.response ? err.response.data.message : err.message;
        }
    };

    const logout = () => {
        user.value = null;
        isAuthenticated.value = false;
        localStorage.removeItem('token'); // Remove token from local storage
        delete apiClient.defaults.headers.common['Authorization'];
        router.push({ name: 'Login' });
    };

    return {
        user,
        error,
        login,
        register,
        logout,
        fetchUser,
        isAuthenticated,
    };
});
