import { defineStore } from 'pinia';
import { ref } from 'vue';
import { useRouter } from 'vue-router';
import apiClient from '../plugins/apiClient';

export const useAuthStore = defineStore('auth', () => {
    const router = useRouter();
    const user = ref(null);
    const error = ref(null);
    const isAuthenticated = ref(false);

    const login = async (credentials) => {
        try {
            const response = await apiClient.post('/Auth/login', credentials);
            user.value = response.data;
            error.value = null;
            isAuthenticated.value = true;
            router.push({ name: 'Home' });
        } catch (err) {
            console.error('API error', err);
            error.value = err.response ? err.response.data.message : err.message;
        }
    };

    const register = async (userData) => {
        try {
            const response = await apiClient.post('/Auth/register', userData);
            user.value = response.data;
            error.value = null;
            isAuthenticated.value = true;
            router.push({ name: 'Home' });
        } catch (err) {
            console.error('API error', err);
            error.value = err.response ? err.response.data.message : err.message;
        }
    };

    const logout = () => {
        user.value = null;
        isAuthenticated.value = false;
        router.push({ name: 'Login' });
    };

    return {
        user,
        error,
        login,
        register,
        logout,
        isAuthenticated,
    };
});
